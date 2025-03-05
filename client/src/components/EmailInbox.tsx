import { useState, useEffect, useMemo } from "react";
import { Box, Button, VStack, Text, Heading, Container, Card, Flex, HStack, Group } from "@chakra-ui/react";
import axios from "axios";
import {
  PaginationItems,
  PaginationNextTrigger,
  PaginationPageText,
  PaginationPrevTrigger,
  PaginationRoot,
} from "@/components/ui/pagination"

interface Email {
  id: number;
  sender: string;
  subject: string;
  body: string;
  isPhishing: boolean;
  difficulty: number;
  hiddenLink: string

  isRead: boolean;
}

const PAGE_SIZE = 6;


const EmailInbox = () => {
  const [emails, setEmails] = useState<Email[]>([]);
  const [selectedEmail, setSelectedEmail] = useState<Email | null>(null);
  const [loading, setLoading] = useState(false);
  const [currentPage, setCurrentPage] = useState(1);


  useEffect(() => {
    setLoading(true);
    axios
      .get<Email[]>("https://localhost:7225/api/Emails/random")
      .then((response) => {
        setEmails(response.data);
      })
      .catch((error) => {
        console.error("Error fetching emails:", error);
      })
      .finally(() => {
        setLoading(false);
      });
  }, []);



  const markAsRead = (emailId: number) => {
    setEmails((prevEmails) =>
      prevEmails.map((email) =>
        email.id === emailId ? { ...email, isRead: true } : email
      )
    );
  };

  const sortedEmails = useMemo(
    () => emails.slice().sort((a, b) => a.difficulty - b.difficulty),
    [emails]
  );

  //Pagination
  const totalEmails = sortedEmails.length; //for count
  const paginatedEmails = sortedEmails.slice((currentPage - 1) * PAGE_SIZE, currentPage * PAGE_SIZE);

  return (
    <>
      <Flex flex="1" >
        <VStack width="350px" p={4} align="stretch" bg="gray.100" justify="space-between">
          {loading ? (
            <Text>Loading emails...</Text>
          ) : (
              
            paginatedEmails.map((email) => (
              <Card.Root
                height="100px"
                _hover={{ bg: "gray.100" }}
                key={email.id}
                p={3}
                borderRadius="2xl"
                bg={"gray.100"}
                shadow="lg"
                cursor="pointer"
                onClick={() => { setSelectedEmail(email); markAsRead(email.id); }}
              >
                <Card.Title fontWeight={email.isRead ? "medium" : "bold"}>
                  {email.sender} {email.difficulty} {totalEmails}
                </Card.Title>
                <Card.Description>{email.subject}</Card.Description>
              </Card.Root>
                ))
            )}
          {/* Pagination */}
          <PaginationRoot
            count={totalEmails}
            pageSize={PAGE_SIZE}
            defaultPage={1}
            page={currentPage}
            onPageChange={(e) => setCurrentPage(e.page)}
          >
            <HStack gap="4" mt={4}>
              <PaginationPrevTrigger />
              <PaginationPageText />
              <PaginationNextTrigger />
            </HStack>
          </PaginationRoot>
        </VStack>

        {/* Email Preview */}
        <Box flex="1" p={6} bg="gray.100">
          {selectedEmail ? (
            <>
              <Heading size="md">{selectedEmail.subject}</Heading>
              <Text fontSize="sm" color="gray.500">
                From: {selectedEmail.sender}
              </Text>
              <Box mt={4} p={4} bg="gray.100" borderRadius="lg">
                <Text>{selectedEmail.body}</Text>
                <Text>{selectedEmail.hiddenLink}</Text>
              </Box>
            </>
          ) : (
            <Text>Select an email to preview</Text>
          )}
        </Box>
      </Flex>

    </>
  );

};

export default EmailInbox;
